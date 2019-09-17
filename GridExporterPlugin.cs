using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Torch;
using Torch.API;
using Torch.API.Plugins;

namespace ALE_GridExporter
{
    public class GridExporterPlugin : TorchPluginBase, IWpfPlugin {

        public static GridExporterPlugin Instance { get; private set; }
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        private Control _control;
        public UserControl GetControl() => _control ?? (_control = new Control(this));

        private Persistent<ExportConfig> _config;
        public ExportConfig Config => _config?.Data;

        public void Save() => _config.Save();

        /// <inheritdoc />
        public override void Init(ITorchBase torch) {
            base.Init(torch);
            var configFile = Path.Combine(StoragePath, "GridExporter.cfg");

            try {

                _config = Persistent<ExportConfig>.Load(configFile);

            } catch (Exception e) {
                Log.Warn(e);
            }

            if (_config?.Data == null) {

                Log.Info("Create Default Config, because none was found!");

                _config = new Persistent<ExportConfig>(configFile, new ExportConfig());
                _config.Save();
            }

            Instance = this;
        }

        public string CreatePath(string fileName) {

            var folder = Path.Combine(StoragePath, Config.ExportedGridsPath);
            Directory.CreateDirectory(folder);

            return Path.Combine(folder, fileName + ".sbc");
        }
    }
}
