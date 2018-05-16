// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mailbox
{
    [Register ("MailController")]
    partial class MailController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BodyLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ResumeLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BodyLabel != null) {
                BodyLabel.Dispose ();
                BodyLabel = null;
            }

            if (ResumeLabel != null) {
                ResumeLabel.Dispose ();
                ResumeLabel = null;
            }
        }
    }
}