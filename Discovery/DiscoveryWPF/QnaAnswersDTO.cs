using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoveryWPF
{
    public class QnaAnswersDTO
    {
        public List<AnswerDTO> answers { get; set; }
}

    public class AnswerDTO
    {

        public string answer { get; set; }
        public double score { get; set; }
    }
    
}
