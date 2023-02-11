using ClosedXML.Excel;
using Payments.API.Models;

namespace Payments.API.Data
{
    public static class DataBaseInMemory
    {
        public static List<Payment> GetPayments()
        {
            List<Payment> list = new List<Payment>();

            var xls = new XLWorkbook(@"/Users/heitoralexandresoares/Library/CloudStorage/OneDrive-Pessoal/Dev/Teste Tecnico/data.xlsx");
            var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count();
            for (int l = 2; l <= totalLinhas; l++)
            {
                var id = planilha.Cell($"A{l}").Value.ToString();
                var description = planilha.Cell($"B{l}").Value.ToString();
                var value = decimal.Parse(planilha.Cell($"C{l}").Value.ToString());
                var userId = planilha.Cell($"D{l}").Value.ToString();

                list.Add(new Payment(id, description, value, userId));
            }

            return list;
        }
        public static List<Payment> GetPaymentsByUser(string id_user)
        {
            List<Payment> list = new List<Payment>();

            var xls = new XLWorkbook(@"/Users/heitoralexandresoares/Library/CloudStorage/OneDrive-Pessoal/Dev/Teste Tecnico/data.xlsx");
            var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count();
            for (int l = 2; l <= totalLinhas; l++)
            {

                if (planilha.Cell($"D{l}").Value.ToString() == id_user)
                {
                    var id = planilha.Cell($"A{l}").Value.ToString();
                    var description = planilha.Cell($"B{l}").Value.ToString();
                    var value = decimal.Parse(planilha.Cell($"C{l}").Value.ToString());
                    var userId = planilha.Cell($"D{l}").Value.ToString();

                    list.Add(new Payment(id, description, value, id_user));
                }
            }

            return list;
        }
    }
}