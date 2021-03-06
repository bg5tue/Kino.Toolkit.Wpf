﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Shell;

namespace Kino.Toolkit.Wpf
{
    [StyleTypedProperty(Property = nameof(RibbonStyle), StyleTargetType = typeof(Ribbon))]
    public class ExtendedRibbonWindow : RibbonWindow
    {
        /// <summary>
        /// 标识 RibbonStyle 依赖属性。
        /// </summary>
        public static readonly DependencyProperty RibbonStyleProperty =
            DependencyProperty.Register(nameof(RibbonStyle), typeof(Style), typeof(ExtendedRibbonWindow), new PropertyMetadata(default(Style), OnRibbonStyleChanged));

        /// <summary>
        /// 标识 FunctionBar 依赖属性。
        /// </summary>
        public static readonly DependencyProperty FunctionBarProperty =
            DependencyProperty.Register(nameof(FunctionBar), typeof(WindowFunctionBar), typeof(ExtendedRibbonWindow), new PropertyMetadata(default(WindowFunctionBar), OnFunctionBarChanged));

#pragma warning disable IDE1006 // 命名样式
        private static readonly DependencyPropertyKey IsNonClientActivePropertyKey =
#pragma warning restore IDE1006 // 命名样式
            DependencyProperty.RegisterReadOnly("IsNonClientActive", typeof(bool), typeof(ExtendedRibbonWindow), new FrameworkPropertyMetadata(false));

#pragma warning disable SA1202 // Elements must be ordered by access
        public static readonly DependencyProperty IsNonClientActiveProperty = IsNonClientActivePropertyKey.DependencyProperty;
#pragma warning restore SA1202 // Elements must be ordered by access

        private readonly IntPtr _trueValue = new IntPtr(1);

        public ExtendedRibbonWindow()
        {
            DefaultStyleKey = typeof(ExtendedRibbonWindow);
        }

        /// <summary>
        /// 获取或设置RibbonStyle的值
        /// </summary>
        public Style RibbonStyle
        {
            get => (Style)GetValue(RibbonStyleProperty);
            set => SetValue(RibbonStyleProperty, value);
        }

        /// <summary>
        /// 获取或设置FunctionBar的值
        /// </summary>
        public WindowFunctionBar FunctionBar
        {
            get => (WindowFunctionBar)GetValue(FunctionBarProperty);
            set => SetValue(FunctionBarProperty, value);
        }

        public bool IsNonClientActive
        {
            get
            {
                return (bool)GetValue(IsNonClientActiveProperty);
            }
        }

        /// <summary>
        /// RibbonStyle 属性更改时调用此方法。
        /// </summary>
        /// <param name="oldValue">RibbonStyle 属性的旧值。</param>
        /// <param name="newValue">RibbonStyle 属性的新值。</param>
        protected virtual void OnRibbonStyleChanged(Style oldValue, Style newValue)
        {
            Resources.Remove(typeof(Ribbon));
            if (newValue != null)
            {
                Resources.Add(typeof(Ribbon), newValue);
            }
        }

        /// <summary>
        /// FunctionBar 属性更改时调用此方法。
        /// </summary>
        /// <param name="oldValue">FunctionBar 属性的旧值。</param>
        /// <param name="newValue">FunctionBar 属性的新值。</param>
        protected virtual void OnFunctionBarChanged(WindowFunctionBar oldValue, WindowFunctionBar newValue)
        {
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            if (SizeToContent == SizeToContent.WidthAndHeight && WindowChrome.GetWindowChrome(this) != null)
            {
                InvalidateMeasure();
            }

            IntPtr handle = new WindowInteropHelper(this).Handle;
            HwndSource.FromHwnd(handle).AddHook(new HwndSourceHook(WndProc));
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            SetValue(IsNonClientActivePropertyKey, true);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            SetValue(IsNonClientActivePropertyKey, false);
        }

        private static void OnRibbonStyleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldValue = (Style)args.OldValue;
            var newValue = (Style)args.NewValue;
            if (oldValue == newValue)
            {
                return;
            }

            var target = obj as ExtendedRibbonWindow;
            target?.OnRibbonStyleChanged(oldValue, newValue);
        }

        private static void OnFunctionBarChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldValue = (WindowFunctionBar)args.OldValue;
            var newValue = (WindowFunctionBar)args.NewValue;
            if (oldValue == newValue)
            {
                return;
            }

            var target = obj as ExtendedRibbonWindow;
            target?.OnFunctionBarChanged(oldValue, newValue);
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == WindowNotifications.WM_NCACTIVATE)
                SetValue(IsNonClientActivePropertyKey, wParam == _trueValue);

            return IntPtr.Zero;
        }
    }
}
