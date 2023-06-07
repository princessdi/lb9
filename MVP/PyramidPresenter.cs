using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public class PyramidPresenter
    {
        private readonly IPyramidModel _model;
        private readonly IPyramidView _view;

        public PyramidPresenter(IPyramidView view, IPyramidModel model)
        {
            _model = model;
            _view = view;
        }

        public void SetPyramidData(double baseSide, double height)
        {
            _model.BaseSide = baseSide;
            _model.Height = height;

            var baseArea = _model.BaseArea;
            var sideArea = _model.Apothem * (_model.BaseSide * 3 / 2);

            var totalArea = baseArea + sideArea;
            var volume = _model.Height * _model.BaseArea / 3;

            _view.SetArea(totalArea);
            _view.SetVolume(volume);
        }
    }
}
