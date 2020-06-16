namespace csharp_web_dev_lsn9exceptions
{
    public class GradeBook
    {
        private string fileName;

        private int Grade = 0; 

        public string CheckFileExtension(string fileName)
        {
            if (fileName.EndsWith(".cs"))
            {
                Grade = 1;
            }
            else
            {
                Grade = 0;
            }
            return Grade.ToString();
        }
    }
}

