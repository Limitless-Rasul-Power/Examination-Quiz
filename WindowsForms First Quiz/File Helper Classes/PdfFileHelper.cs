using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing.Imaging;
using System.IO;
using WindowsForms_First_Quiz.Entity_Classes;

namespace WindowsForms_First_Quiz
{
    public static class PdfFileHelper
    {
        public static void WriteUserResultToFile(QuizUser user, string fileName)
        {
            if (user != null)
            {
                if (!Directory.Exists("Quiz Results"))
                    Directory.CreateDirectory("Quiz Results");

                if (string.IsNullOrWhiteSpace(fileName))
                    fileName = $"result {Guid.NewGuid()}";

                var document = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                PdfWriter.GetInstance(document, new FileStream($"Quiz Results/{fileName}.pdf", FileMode.OpenOrCreate));

                string imagePath = "../../Photos/result.jpg";
                document.Open();

                using (FileStream fs = new FileStream(imagePath, FileMode.Open))
                {
                    var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Jpeg);
                    png.ScalePercent(5f);
                    png.ScaleToFit(100f, 100f);
                    png.SetAbsolutePosition(document.Left, document.Top - 50);
                    document.Add(png);
                }

                document.Add
                (
                    new Paragraph("")
                    {
                        SpacingBefore = 70f,
                    }
                );


                var pdfTable = new PdfPTable(4)
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                pdfTable.AddCell(CreateNewCell($"Email(Username) = {user.UsernameOrEmail}", 4));
                pdfTable.AddCell(CreateNewCell($"Test Name = {user.QuizFileName}", 4));
                pdfTable.AddCell(CreateNewCell("Empty Answer Count", 1));
                pdfTable.AddCell(CreateNewCell("Wrong Answer Count", 1));
                pdfTable.AddCell(CreateNewCell("Right Answer Count", 1));
                pdfTable.AddCell(CreateNewCell("Question Count", 1));

                pdfTable.AddCell(CreateNewCell(user.EmptyAnsweredQuestionNumber.ToString(), 1));
                pdfTable.AddCell(CreateNewCell(user.WrongAnsweredQuestionNumber.ToString(), 1));
                pdfTable.AddCell(CreateNewCell(user.RightAnsweredQuestionNumber.ToString(), 1));
                pdfTable.AddCell(CreateNewCell(user.QuizQuestionCount.ToString(), 1));

                document.Add(pdfTable);

                document.Add
                (
                    new Paragraph("")
                    {
                        SpacingBefore = 20f,
                    }
                );

                var paragraph = new Paragraph($"You answered {(user.RightAnsweredQuestionNumber * 100) / user.QuizQuestionCount} % of questions right.")
                {
                    Alignment = Element.ALIGN_CENTER
                };
                document.Add(paragraph);
    

                document.Close();

            }


        }

        private static PdfPCell CreateNewCell(string cellName, int colSpan)
        {
            return new PdfPCell(new Phrase(cellName))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                MinimumHeight = 22f,
                Colspan = colSpan
            };
        }

    }
}
