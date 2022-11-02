using DinkToPdf;
using DinkToPdf.Contracts;
using System.Collections.Generic;
using WebMVC.Models;

public class ReportService : IReportService
{
    private readonly IConverter _converter;
    public ReportService(IConverter converter)
    {
        _converter = converter;
    }

    public class Settings
    {
        public ObjectSettings objectSettings { get; set; }
        public GlobalSettings globalSettings { get; set; }
    }

    private Settings GetPdfSettings(string html)
    {

        Settings settings = new Settings();
        settings.globalSettings = new GlobalSettings();
        settings.globalSettings.ColorMode = ColorMode.Color;
        settings.globalSettings.Orientation = Orientation.Portrait;
        settings.globalSettings.PaperSize = PaperKind.A4;
        settings.globalSettings.Margins = new MarginSettings { Top = 15, Bottom = 15 };
        settings.objectSettings = new ObjectSettings();
        settings.objectSettings.PagesCount = true;
        settings.objectSettings.HtmlContent = html;
        WebSettings webSettings = new WebSettings();
        webSettings.DefaultEncoding = "utf-8";
        HeaderSettings headerSettings = new HeaderSettings();
        headerSettings.FontSize = 13;
        headerSettings.FontName = "arial";
        headerSettings.Spacing = 4;
        headerSettings.Left = "Bolsa de Trabajo - UTN FRRO";
        headerSettings.Right = "[page] de [toPage]";
        headerSettings.Line = true;
        settings.objectSettings.HeaderSettings = headerSettings;
        settings.objectSettings.WebSettings = webSettings;

        return settings;
    }

    public byte[] GeneratePdfReport(List<JobProfile> jobProfiles)
    {

        string rows = "";

        foreach (JobProfile jobProfile in jobProfiles)
        {
            rows += $@"
            <tr>
                <td>
                {jobProfile.Id}
                </td>
                <td>
                {jobProfile.Position}
                </td>
                <td>
                {jobProfile.Description}
                </td>
                <td>
                {jobProfile.Capacity}
                </td>
                <td>
                {jobProfile.Address}
                </td>
                <td>
                {(jobProfile.Type == "Relationship" ? "Relación de Dependencia" : "Pasantía")}
                </td>
            </tr>
";
        }

        string html = 
        $@"
        <!DOCTYPE html>
        <html lang=""en"">
            <body style=""font-family:arial"">
                <h1>Reporte de Trabajos Creados</h1>
                <table style=""width:100%"">
                  <tr style=""color:#ffffff;background:#007bff;text-transform:uppercase"">
                    <th>#</th>
                    <th>Puesto de Trabajo</th>
                    <th>Descripción</th>
                    <th>Capacidad</th>
                    <th>Dirección</th>
                    <th>Tipo</th>
                  </tr>
                 {rows}
                </table>
            </body>
        </html>
        ";


        Settings settings = GetPdfSettings(html);
        
        HtmlToPdfDocument htmlToPdfDocument = new HtmlToPdfDocument()
        {
            GlobalSettings = settings.globalSettings,
            Objects = { settings.objectSettings },
        };
        return _converter.Convert(htmlToPdfDocument);
    }

    public byte[] GeneratePdfReport(string PORVERSE)
    {

        Settings settings = GetPdfSettings("");

        HtmlToPdfDocument htmlToPdfDocument = new HtmlToPdfDocument()
        {
            GlobalSettings = settings.globalSettings,
            Objects = { settings.objectSettings },
        };
        return _converter.Convert(htmlToPdfDocument);
    }
}