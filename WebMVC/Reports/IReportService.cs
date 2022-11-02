using System.Collections.Generic;
using WebMVC.Models;

public interface IReportService
{
    public byte[] GeneratePdfReport(List<JobProfile> jobProfiles);
    public byte[] GeneratePdfReport(string PORVERSE);
}