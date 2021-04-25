using System;
using System.IO;
using Microsoft.Office.Interop.Outlook;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Altered
{
    class SendEmail
    {
        private string Document_number { get; set; }

        private string EmailAddress { get; set; }

        Application outlookApplication = new Application();

        public SendEmail()
        {

        }

        public SendEmail(string document_number, string emailAddress)
        {
            Document_number = document_number;
            EmailAddress = emailAddress;

            Send();

        }

        private void Send()
        {
            string location = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\");

            string invoiceName = Document_number + ".pdf";
            string fullPath = location + invoiceName;

            //Send the email
            MailItem mailItem = (MailItem)outlookApplication.Application.CreateItem(OlItemType.olMailItem);
            mailItem.Display(false);
            mailItem.Subject = "Invoice: " + Document_number;
            mailItem.To = EmailAddress;
            mailItem.Body = "Good day \r\n \r\n Attached, find your invoice. \r\n Please note that you require Adobe Reader or similar to view your document. \r\n \r\n Regards.";
            mailItem.Importance = OlImportance.olImportanceNormal;
            mailItem.Display(false);
            mailItem.Attachments.Add(fullPath);
            mailItem.Send();
        }
    }
}
