using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //  IoC ContainerへICalculationServiceへの参照をどこからでも要求できるようにする
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            // アプリケーションの起動時に表示するViewに必要なViewModelを登録
            RegisterAppStart<TipViewModel>();
        }
    }
}
