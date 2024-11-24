using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSharpTrainingCamp301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        TrainingCampEfTravelDbEntities db = new TrainingCampEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Location.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgTourPrice.Text = db.Location.Average(x => x.Price).Value.ToString("F2") + " ₺";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(c => c.Country).FirstOrDefault();

            lblEdinburghLocationCapacity.Text = db.Location.Where(x => x.City == "Edinburgh").Select(c => c.Capacity).FirstOrDefault().ToString();

            lblItalyCapacityAvg.Text = db.Location.Where(x=>x.Country == "Italy").Average(x => x.Capacity).ToString();
            
            var salernoGuideId = db.Location.Where(x => x.City == "Salerno").Select(g => g.GuideId).FirstOrDefault();
            lblSalernoGuideName.Text = db.Guide.Where(x => x.GuideId == salernoGuideId).Select(n => n.GuideName + " " + n.GuideSurname).FirstOrDefault();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(c => c.City).FirstOrDefault();

            var maxPrice= db.Location.Max(p => p.Price);
            lblMaxPriceLocation.Text = db.Location.Where(m => m.Price == maxPrice).Select(c => c.City).FirstOrDefault();

            var guideIdByNameBetulAvci = db.Guide.Where(g => g.GuideName == "Betül" && g.GuideSurname == "Avcı").Select(i => i.GuideId).FirstOrDefault();
            lblBetulAvciLocationCount.Text = db.Location.Where(i => i.GuideId == guideIdByNameBetulAvci).Count().ToString();
        }
    }
}
