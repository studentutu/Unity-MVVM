﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityMVVM.Binding.Converters;

namespace UnityMVVM
{
    namespace Examples
    {
        public class StateToVisibilityConverter : ValueConverterBase
        {

            public ApplicationState VisibleState;
            public ApplicationState HiddenState;
            public ApplicationState InvisibleState;

            public override object Convert(object value, Type targetType, object parameter)
            {
                ApplicationState state = (ApplicationState)value;
                if (state == VisibleState)
                    return Visibility.Visible;
                if (state == HiddenState)
                    return Visibility.Hidden;
                if (state == InvisibleState)
                    return Visibility.Invisible;

                return null;
            }

            public override object ConvertBack(object value, Type targetType, object parameter)
            {
                throw new NotImplementedException();
            }
        }

    }
}

