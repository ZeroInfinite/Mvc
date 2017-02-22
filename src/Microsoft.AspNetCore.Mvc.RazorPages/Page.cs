// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    /// <summary>
    /// A base class for a Razor page.
    /// </summary>
    public abstract class Page : RazorPageBase, IRazorPage
    {
        private IUrlHelper _urlHelper;
        private PageArgumentBinder _binder;

        /// <summary>
        /// The <see cref="PageContext"/>.
        /// </summary>
        public PageContext PageContext { get; set; }

        public PageArgumentBinder Binder
        {
            get
            {
                if (_binder == null)
                {
                    _binder = PageContext.HttpContext.RequestServices.GetRequiredService<PageArgumentBinder>();
                }

                return _binder;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _binder = value;
            }
        }

        /// <summary>
        /// Gets the <see cref="ITempDataDictionary"/> from the <see cref="PageContext"/>.
        /// </summary>
        /// <remarks>Returns null if <see cref="PageContext"/> is null.</remarks>
        public ITempDataDictionary TempData => PageContext?.TempData;

        /// <inheritdoc />
        public override void EnsureRenderedBodyOrSections()
        {
            throw new NotSupportedException();
        }

        public override void BeginContext(int position, int length, bool isLiteral)
        {
            const string BeginContextEvent = "Microsoft.AspNetCore.Mvc.Razor.BeginInstrumentationContext";

            if (DiagnosticSource?.IsEnabled(BeginContextEvent) == true)
            {
                DiagnosticSource.Write(
                    BeginContextEvent,
                    new
                    {
                        httpContext = ViewContext,
                        path = Path,
                        position = position,
                        length = length,
                        isLiteral = isLiteral,
                    });
            }
        }

        public override void EndContext()
        {
            const string EndContextEvent = "Microsoft.AspNetCore.Mvc.Razor.EndInstrumentationContext";

            if (DiagnosticSource?.IsEnabled(EndContextEvent) == true)
            {
                DiagnosticSource.Write(
                    EndContextEvent,
                    new
                    {
                        httpContext = ViewContext,
                        path = Path,
                    });
            }
        }

        protected IActionResult Redirect(string url)
        {
            return new RedirectResult(url);
        }

        protected IActionResult View()
        {
            return new PageViewResult(this);
        }
    }
}
