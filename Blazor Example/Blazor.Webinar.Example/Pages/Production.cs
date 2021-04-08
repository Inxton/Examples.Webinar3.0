using Plc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Webinar.Example.Pages
{
    public partial class Production
    {
        private stProduction ProductionTwin { get; set; } = PlcConnector.Entry.Plc.MAIN.production;


        protected override void OnInitialized()
        {
     
            UpdateValuesOnChange(ProductionTwin);
            base.OnInitialized();
        }
        private void Start()
        {
            if (ProductionTwin.progress_bar_value.Cyclic != 0)
            {
                ProductionTwin.progress_bar_value.Cyclic = 0;
            }

            ProductionTwin.progress_bar_status.Cyclic = true;
        }
        private void Pause()
        {
            ProductionTwin.progress_bar_status.Cyclic = false;
        }
        private void Continue()
        {
            ProductionTwin.progress_bar_status.Cyclic = true;
        }
        private void Reset()
        {
            ProductionTwin.progress_bar_status.Cyclic = false;
            ProductionTwin.progress_bar_value.Cyclic = 0;
            
        }
    }

}
