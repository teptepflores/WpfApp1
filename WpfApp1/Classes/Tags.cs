using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Classes
{
    class Tags
    {

        public class Prediction
        {
            public string TagId { get; set; }
            public string Tag { get; set; }
            public string Probability { get; set; }

        }

        public class CustomVision
        {
            public string Id { get; set; }
            public string Project { get; set; }
            public string Iteration { get; set; }
            public string Created { get; set; }
            public List<Prediction> Predictions { get; set; }
        }
    }
}
