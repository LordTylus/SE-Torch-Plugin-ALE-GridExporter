using Torch;

namespace ALE_GridExporter {
    
    public class ExportConfig : ViewModel
    {
        private bool _keepOriginalOwner = true;

        private bool _includeConnectedGrids = true;

        private string _path = "ExportedGrids";

        public bool KeepOriginalOwner { get => _keepOriginalOwner; set => SetValue(ref _keepOriginalOwner, value); }

        public bool IncludeConnectedGrids { get => _includeConnectedGrids; set => SetValue(ref _includeConnectedGrids, value); }

        public string ExportedGridsPath { get => _path; set => SetValue(ref _path, value); }
    }
}
