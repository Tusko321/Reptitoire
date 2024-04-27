using System.Windows.Forms.DataVisualization.Charting;

namespace Reptitoire.ReptitoireManager.FeedEvents
{
    public class FeedLogChart
    {
        private Chart chart;

        public FeedLogChart(Chart chart)
        {
            this.chart = chart;
        }

        public void Clear()
        {
            chart.Series[0].Points.Clear();
        }

        public void AddFeeder(string species, int amount)
        {
            int index = ContainsFeeder(species);
            if (index != -1)
            {
                chart.Series[0].Points[index].YValues[0] += amount;
            }
            else
            {
                chart.Series[0].Points.Add(new DataPoint(0, amount));
                chart.Series[0].Points[chart.Series[0].Points.Count - 1].LegendText = species;
                chart.Series[0].Points[chart.Series[0].Points.Count - 1].AxisLabel = species;
            }
        }

        public void UpdatePercentages()
        {
            float[] percentages = new float[chart.Series[0].Points.Count];

            int total = 0;
            for(int i = 0; i < percentages.Length; i++)
                total += (int)chart.Series[0].Points[i].YValues[0];

            for (int i = 0; i < percentages.Length; i++)
                percentages[i] = (float)chart.Series[0].Points[i].YValues[0] / (float)total * 100;

            for (int i = 0; i < percentages.Length; i++)
                chart.Series[0].Points[i].Label = percentages[i].ToString(".0") + "%";
        }

        public int ContainsFeeder(string species)
        {
            int index = 0;
            foreach(var item in chart.Series[0].Points)
            {
                if(item.AxisLabel.Equals(species)) return index;
                index++;
            }

            return -1;
        }
    }
}
