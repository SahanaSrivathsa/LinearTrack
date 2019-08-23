using System.IO;

namespace Linear_Track_GUI
{
    public static class CsvFiles
    {
        public static StreamWriter trainingCsv;
        public static StreamReader LTreader;
        public static StreamWriter LTwriter;

        public static void openLTreader()
        {
            LTreader = new StreamReader($"C:\\Users\\sahanasrivathsa\\Documents\\Barnes Lab\\LTtraining\\LTrats.Csv");
        }

        public static void openLTwriter()
        {
            LTwriter = new StreamWriter($"C:\\Users\\sahanasrivathsa\\Documents\\Barnes Lab\\LTtraining\\LTrats.Csv");
        }

        public static void closeLTreader()
        {
            LTreader.Close();
        }

        public static void openTrainingReview(string number)
        {
            trainingCsv =
                new StreamWriter(
                    ($"C:\\Users\\sahanasrivathsa\\Documents\\Barnes Lab\\LTtraining\\LTtraining_{number}.csv"),
                    true);
        }

        public static void closeWriter()
        {
            LTwriter.Close();
        }

        public static void closeTraining()
        {
            trainingCsv.Close();
        }

    }
}
