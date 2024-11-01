namespace sms_api.Calculations
{
    public class Calculator
    {
        public double GetPercentage(double  maxMarks,double obtMarks)
        {
            if (maxMarks == 0)
            {
                return 0.0;
            }
            else
            {
                var percentage = (obtMarks / maxMarks)*100;
                return percentage;
            }
        }
        public double CalculateAverage(double totalMarks,int numberOfSubjects)
        {
            if (numberOfSubjects == 0)
            {
                return 0.0;
            }
            else
            {
                var average = (totalMarks / numberOfSubjects);
                return average;
            }
        }
    }
}
