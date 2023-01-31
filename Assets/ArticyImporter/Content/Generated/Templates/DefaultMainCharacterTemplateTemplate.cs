//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.A_Coven_Of_Cards;
using Articy.A_Coven_Of_Cards.Features;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.A_Coven_Of_Cards.Templates
{
    
    
    [Serializable()]
    public class DefaultMainCharacterTemplateTemplate : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueDefaultExtendedCharacterFeatureFeature mDefaultExtendedCharacterFeature = new ArticyValueDefaultExtendedCharacterFeatureFeature();
        
        [SerializeField()]
        private ArticyValueDefaultBasicCharacterFeatureFeature mDefaultBasicCharacterFeature = new ArticyValueDefaultBasicCharacterFeatureFeature();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public Articy.A_Coven_Of_Cards.Features.DefaultExtendedCharacterFeatureFeature DefaultExtendedCharacterFeature
        {
            get
            {
                return mDefaultExtendedCharacterFeature.GetValue();
            }
            set
            {
                mDefaultExtendedCharacterFeature.SetValue(value);
            }
        }
        
        public Articy.A_Coven_Of_Cards.Features.DefaultBasicCharacterFeatureFeature DefaultBasicCharacterFeature
        {
            get
            {
                return mDefaultBasicCharacterFeature.GetValue();
            }
            set
            {
                mDefaultBasicCharacterFeature.SetValue(value);
            }
        }
        
        public UInt64 OwnerId
        {
            get
            {
                return mOwnerId;
            }
            set
            {
                mOwnerId = value;
                DefaultExtendedCharacterFeature.OwnerId = value;
                DefaultBasicCharacterFeature.OwnerId = value;
            }
        }
        
        public UInt32 OwnerInstanceId
        {
            get
            {
                return mOwnerInstanceId;
            }
            set
            {
                mOwnerInstanceId = value;
                DefaultExtendedCharacterFeature.OwnerInstanceId = value;
                DefaultBasicCharacterFeature.OwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.A_Coven_Of_Cards.Templates.DefaultMainCharacterTemplateTemplate newClone = ((Articy.A_Coven_Of_Cards.Templates.DefaultMainCharacterTemplateTemplate)(aClone));
            if ((DefaultExtendedCharacterFeature != null))
            {
                newClone.DefaultExtendedCharacterFeature = ((Articy.A_Coven_Of_Cards.Features.DefaultExtendedCharacterFeatureFeature)(DefaultExtendedCharacterFeature.CloneObject(newClone, aFirstClassParent)));
            }
            if ((DefaultBasicCharacterFeature != null))
            {
                newClone.DefaultBasicCharacterFeature = ((Articy.A_Coven_Of_Cards.Features.DefaultBasicCharacterFeatureFeature)(DefaultBasicCharacterFeature.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.A_Coven_Of_Cards.Templates.DefaultMainCharacterTemplateTemplate clone = new Articy.A_Coven_Of_Cards.Templates.DefaultMainCharacterTemplateTemplate();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "DefaultExtendedCharacterFeature"))
                {
                    DefaultExtendedCharacterFeature.setProp(featureProperty, aValue);
                }
                if ((featurePath == "DefaultBasicCharacterFeature"))
                {
                    DefaultBasicCharacterFeature.setProp(featureProperty, aValue);
                }
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "DefaultExtendedCharacterFeature"))
                {
                    return DefaultExtendedCharacterFeature.getProp(featureProperty);
                }
                if ((featurePath == "DefaultBasicCharacterFeature"))
                {
                    return DefaultBasicCharacterFeature.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}