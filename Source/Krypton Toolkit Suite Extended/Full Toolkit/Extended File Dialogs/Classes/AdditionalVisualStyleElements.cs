﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.472/blob/master/LICENSE
 *
 */
#endregion

using System.Windows.Forms.VisualStyles;

namespace ExtendedFileDialogs.Classes
{
    /// <summary>
    /// Contains classes that provide additional visual style elements not available through the regular
    /// <see cref="VisualStyleElement"/> class.
    /// </summary>
    /// <threadsafety instance="false" static="false" />
    public static class AdditionalVisualStyleElements
    {
        /// <summary>
        /// Provides <see cref="VisualStyleElement"/> objects for
        /// text styles.
        /// </summary>
        /// <remarks>
        /// <note>
        ///   Use of these styles requires Windows Vista or a newer version of Windows.
        /// </note>
        /// </remarks>
        /// <threadsafety instance="false" static="false" />
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class TextStyle
        {
            private const string _className = "TEXTSTYLE";

            private static VisualStyleElement _mainInstruction;
            private static VisualStyleElement _bodyText;

            /// <summary>
            /// Gets a visual style element that represents the main instruction in a dialog box.
            /// </summary>
            /// <value>
            /// A <see cref="VisualStyleElement"/> representing the style for the main instruction.
            /// </value>
            public static VisualStyleElement MainInstruction
            {
                get { return _mainInstruction ?? (_mainInstruction = VisualStyleElement.CreateElement(_className, 1, 0)); }
            }

            /// <summary>
            /// Gets a visual style element that represents the body text in a dialog box.
            /// </summary>
            /// <value>
            /// A <see cref="VisualStyleElement"/> representing the style for the body text.
            /// </value>
            public static VisualStyleElement BodyText
            {
                get { return _bodyText ?? (_bodyText = VisualStyleElement.CreateElement(_className, 4, 0)); }
            }

        }

        /// <summary>
        /// Provides <see cref="VisualStyleElement"/> objects
        /// for task dialog related elements.
        /// </summary>
        /// <remarks>
        /// <note>
        ///   Use of these styles requires Windows Vista or a newer version of Windows.
        /// </note>
        /// </remarks>
        /// <threadsafety instance="false" static="false" />
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class TaskDialog
        {
            private const string _className = "TASKDIALOG";

            private static VisualStyleElement _primaryPanel;
            private static VisualStyleElement _secondaryPanel;

            /// <summary>
            /// Gets a visual style element that represents the primary panel of a task dialog.
            /// </summary>
            /// <value>
            /// A <see cref="VisualStyleElement"/> representing the style for the primary panel.
            /// </value>
            public static VisualStyleElement PrimaryPanel
            {
                get { return _primaryPanel ?? (_primaryPanel = VisualStyleElement.CreateElement(_className, 1, 0)); }
            }

            /// <summary>
            /// Gets a visual style element that represents the secondary panel of a task dialog.
            /// </summary>
            /// <value>
            /// A <see cref="VisualStyleElement"/> representing the style for the secondary panel.
            /// </value>
            public static VisualStyleElement SecondaryPanel
            {
                get { return _secondaryPanel ?? (_secondaryPanel = VisualStyleElement.CreateElement(_className, 8, 0)); }
            }
        }
    }
}