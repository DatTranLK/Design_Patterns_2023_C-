using DesignPatterns2023.Observer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Observer.Models
{
    public class VideoData : Subject
    {
        #region Private Properties
        private string _title;
        private string _description;
        private string _fileName;
        #endregion

        #region GetSetProperties
        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string title)
        {
            _title = title;
            VideoDataChanged();
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
            VideoDataChanged();
        }
        public string GetFileName()
        {
            return _fileName;
        }
        public void SetFileName(string fileName)
        {
            _fileName = fileName;
            VideoDataChanged();
        }
        #endregion
        private void VideoDataChanged()
        {
            NotifyObserver(null);
        }
    }
}
