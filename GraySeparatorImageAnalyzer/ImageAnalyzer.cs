using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraySeparatorImageAnalyzer
{
    public class ImageAnalyzer
    {
        public string Analyse(string content)
        {
            string uppercasedContent = content.ToUpper();
            return uppercasedContent;
        }
    }
}
