using System.Globalization;

namespace ChainOfResponsibilityPattern
{
    public class Request
    {
        private string requsetType;
        private string requsetContent;
        private int number;

        public string RequsetType
        {
            get
            {
                return requsetType;
            }

            set
            {
                requsetType = value;
            }
        }

        public string RequsetContent
        {
            get
            {
                return requsetContent;
            }

            set
            {
                requsetContent = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}