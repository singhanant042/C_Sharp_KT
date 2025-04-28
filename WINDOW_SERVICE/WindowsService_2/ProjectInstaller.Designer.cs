namespace WindowsService_2
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TickCounterProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.TickCounterServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // TickCounterProcessInstaller
            // 
            this.TickCounterProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.TickCounterProcessInstaller.Password = null;
            this.TickCounterProcessInstaller.Username = null;
            // 
            // TickCounterServiceInstaller
            // 
            this.TickCounterServiceInstaller.Description = "Makes Event Logger every 5 seconds";
            this.TickCounterServiceInstaller.ServiceName = "Tick Counter";
            this.TickCounterServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.TickCounterProcessInstaller,
            this.TickCounterServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller TickCounterProcessInstaller;
        private System.ServiceProcess.ServiceInstaller TickCounterServiceInstaller;
    }
}