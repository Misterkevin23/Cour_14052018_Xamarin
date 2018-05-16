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

namespace MailBox_iOS
{
    [Register ("MailController")]
    partial class MailController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bodyLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ResumeLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bodyLabel != null) {
                bodyLabel.Dispose ();
                bodyLabel = null;
            }

            if (ResumeLabel != null) {
                ResumeLabel.Dispose ();
                ResumeLabel = null;
            }
        }
    }
}