﻿using Education.Model;
using Education.Pages;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using WebExpress.Pages;
using WebExpress.Workers;

namespace Education
{
    public class EducationPlugin : WebExpress.Plugins.Plugin
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public EducationPlugin()
            : base("Education", "/Asserts/img/Education.svg")
        {
        }

        /// <summary>
        /// Initialisierung des Prozesszustandes. Hier können z.B. verwaltete Ressourcen geladen werden. 
        /// </summary>
        /// <param name="configFileName">Der Dateiname der Konfiguration oder null</param>
        public override void Init(string configFileName = null)
        {
            base.Init(configFileName);

            ViewModel.Instance.Context = Context;
            ViewModel.Instance.Init();
            Context.Log.Info(MethodBase.GetCurrentMethod(), "Education Plugin initialisierung");

            // Ressourcen
            SiteMap.AddPage("Assets", "Assets", (x) => new WorkerFile(x, Context.AssetBaseFolder));
            SiteMap.AddPath("Assets", true);
            
            // Seiten
            SiteMap.AddPage("Home", "", (x) => new WorkerPage<PageHome>(x));
            SiteMap.AddPage("Tutorials", "tutorial", (x) => new WorkerPage<PageTutorial>(x));
            SiteMap.AddPage("Controls", "control", (x) => new WorkerPage<PageControl>(x));
            SiteMap.AddPage("Alert", "alert", (x) => new WorkerPage<PageControlAlert>(x));
            SiteMap.AddPage("Badge", "badge", (x) => new WorkerPage<PageControlBadge>(x));
            SiteMap.AddPage("Breadcrumb", "breadcrumb", (x) => new WorkerPage<PageControlBreadcrumb>(x));
            SiteMap.AddPage("Callout", "callout", (x) => new WorkerPage<PageControlPanelCallout>(x));
            SiteMap.AddPage("Icon", "icon", (x) => new WorkerPage<PageControlIcon>(x));
            SiteMap.AddPage("Line", "line", (x) => new WorkerPage<PageControlLine>(x));
            SiteMap.AddPage("Progress", "progress", (x) => new WorkerPage<PageControlProgress>(x));
            SiteMap.AddPage("Html", "html", (x) => new WorkerPage<PageHtml>(x));
            SiteMap.AddPage("Hilfe", "help", (x) => new WorkerPage<PageHelp>(x));

            SiteMap.AddPath("Home");
            SiteMap.AddPath("Home/Tutorials");
            SiteMap.AddPath("Home/Controls");
            SiteMap.AddPath("Home/Controls/Alert");
            SiteMap.AddPath("Home/Controls/Badge");
            SiteMap.AddPath("Home/Controls/Breadcrumb");
            SiteMap.AddPath("Home/Controls/Callout");
            SiteMap.AddPath("Home/Controls/Icon");
            SiteMap.AddPath("Home/Controls/Line");
            SiteMap.AddPath("Home/Controls/Progress");
            SiteMap.AddPath("Home/Html");
            SiteMap.AddPath("Home/Hilfe");
        }

        /// <summary>
        /// Wird aufgerufen, wenn das Plugin mit der Arbeit beginnt
        /// </summary>
        public override void Run()
        {
            base.Run();

            Task.Run(() => 
            {
                // Loop
                while (true)
                {
                    try
                    {
                        Update();
                    }
                    finally
                    {
                        Thread.Sleep(60000);
                    }
                }
            });
        }

        /// <summary>
        /// Diese Methode wird aufgerufen, nachdem das Fenster aktiv ist.
        /// </summary>
        private void Update()
        {
            ViewModel.Instance.Update();
        }
    }
}
