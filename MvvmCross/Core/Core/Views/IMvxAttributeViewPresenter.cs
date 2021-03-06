﻿using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace MvvmCross.Core.Views
{
    public interface IMvxAttributeViewPresenter : IMvxViewPresenter
    {
        IMvxViewModelTypeFinder ViewModelTypeFinder { get; set; }
        IMvxViewsContainer ViewsContainer { get; set; }
        Dictionary<Type, MvxPresentationAttributeAction> AttributeTypesToActionsDictionary { get; }
        void RegisterAttributeTypes();

        //TODO: Maybe move those to helper class
        MvxBasePresentationAttribute GetPresentationAttribute(MvxViewModelRequest request);
        MvxBasePresentationAttribute CreatePresentationAttribute(Type viewModelType, Type viewType);
        MvxBasePresentationAttribute GetOverridePresentationAttribute(MvxViewModelRequest request, Type viewType);
    }
}
