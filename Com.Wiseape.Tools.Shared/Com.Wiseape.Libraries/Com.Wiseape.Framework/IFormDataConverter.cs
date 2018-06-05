using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Wiseape.Framework
{
    public interface IFormDataConverter
    {
        void PopulateForm(object dataSource, object form);
        void PopulateData(object dataSource, object data);
    }
}
