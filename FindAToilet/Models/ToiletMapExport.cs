﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 

namespace FindAToilet.Models
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://toiletmap.gov.au/", IsNullable = false)]
    public partial class ToiletMapExport
    {

        private ToiletMapExportToiletDetails[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToiletDetails")]
        public ToiletMapExportToiletDetails[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    public partial class ToiletMapExportToiletDetails
    {

        private string nameField;

        private string address1Field;

        private string townField;

        private string stateField;

        private string postcodeField;

        private string addressNoteField;

        private string notesField;

        private ToiletMapExportToiletDetailsGeneralDetails[] generalDetailsField;

        private ToiletMapExportToiletDetailsAccessibilityDetails[] accessibilityDetailsField;

        private ToiletMapExportToiletDetailsOpeningHours[] openingHoursField;

        private ToiletMapExportToiletDetailsFeatures[] featuresField;

        private ToiletMapExportToiletDetailsIcon[] iconField;

        private string statusField;

        private string latitudeField;

        private string longitudeField;

        private string toiletURLField;

        private string lastUpdateDateField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string Postcode
        {
            get
            {
                return this.postcodeField;
            }
            set
            {
                this.postcodeField = value;
            }
        }

        /// <remarks/>
        public string AddressNote
        {
            get
            {
                return this.addressNoteField;
            }
            set
            {
                this.addressNoteField = value;
            }
        }

        /// <remarks/>
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeneralDetails")]
        public ToiletMapExportToiletDetailsGeneralDetails[] GeneralDetails
        {
            get
            {
                return this.generalDetailsField;
            }
            set
            {
                this.generalDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessibilityDetails")]
        public ToiletMapExportToiletDetailsAccessibilityDetails[] AccessibilityDetails
        {
            get
            {
                return this.accessibilityDetailsField;
            }
            set
            {
                this.accessibilityDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OpeningHours")]
        public ToiletMapExportToiletDetailsOpeningHours[] OpeningHours
        {
            get
            {
                return this.openingHoursField;
            }
            set
            {
                this.openingHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Features")]
        public ToiletMapExportToiletDetailsFeatures[] Features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Icon")]
        public ToiletMapExportToiletDetailsIcon[] Icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ToiletURL
        {
            get
            {
                return this.toiletURLField;
            }
            set
            {
                this.toiletURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastUpdateDate
        {
            get
            {
                return this.lastUpdateDateField;
            }
            set
            {
                this.lastUpdateDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    public partial class ToiletMapExportToiletDetailsGeneralDetails
    {

        private string maleField;

        private string femaleField;

        private string unisexField;

        private string facilityTypeField;

        private string toiletTypeField;

        private string accessLimitedField;

        private string paymentRequiredField;

        private string keyRequiredField;

        private string accessNoteField;

        private string parkingField;

        private string parkingNoteField;

        /// <remarks/>
        public string Male
        {
            get
            {
                return this.maleField;
            }
            set
            {
                this.maleField = value;
            }
        }

        /// <remarks/>
        public string Female
        {
            get
            {
                return this.femaleField;
            }
            set
            {
                this.femaleField = value;
            }
        }

        /// <remarks/>
        public string Unisex
        {
            get
            {
                return this.unisexField;
            }
            set
            {
                this.unisexField = value;
            }
        }

        /// <remarks/>
        public string FacilityType
        {
            get
            {
                return this.facilityTypeField;
            }
            set
            {
                this.facilityTypeField = value;
            }
        }

        /// <remarks/>
        public string ToiletType
        {
            get
            {
                return this.toiletTypeField;
            }
            set
            {
                this.toiletTypeField = value;
            }
        }

        /// <remarks/>
        public string AccessLimited
        {
            get
            {
                return this.accessLimitedField;
            }
            set
            {
                this.accessLimitedField = value;
            }
        }

        /// <remarks/>
        public string PaymentRequired
        {
            get
            {
                return this.paymentRequiredField;
            }
            set
            {
                this.paymentRequiredField = value;
            }
        }

        /// <remarks/>
        public string KeyRequired
        {
            get
            {
                return this.keyRequiredField;
            }
            set
            {
                this.keyRequiredField = value;
            }
        }

        /// <remarks/>
        public string AccessNote
        {
            get
            {
                return this.accessNoteField;
            }
            set
            {
                this.accessNoteField = value;
            }
        }

        /// <remarks/>
        public string Parking
        {
            get
            {
                return this.parkingField;
            }
            set
            {
                this.parkingField = value;
            }
        }

        /// <remarks/>
        public string ParkingNote
        {
            get
            {
                return this.parkingNoteField;
            }
            set
            {
                this.parkingNoteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    public partial class ToiletMapExportToiletDetailsAccessibilityDetails
    {

        private string accessibleMaleField;

        private string accessibleFemaleField;

        private string accessibleUnisexField;

        private string accessibleNoteField;

        private string mLAKField;

        private string parkingAccessibleField;

        private string accessibleParkingNoteField;

        /// <remarks/>
        public string AccessibleMale
        {
            get
            {
                return this.accessibleMaleField;
            }
            set
            {
                this.accessibleMaleField = value;
            }
        }

        /// <remarks/>
        public string AccessibleFemale
        {
            get
            {
                return this.accessibleFemaleField;
            }
            set
            {
                this.accessibleFemaleField = value;
            }
        }

        /// <remarks/>
        public string AccessibleUnisex
        {
            get
            {
                return this.accessibleUnisexField;
            }
            set
            {
                this.accessibleUnisexField = value;
            }
        }

        /// <remarks/>
        public string AccessibleNote
        {
            get
            {
                return this.accessibleNoteField;
            }
            set
            {
                this.accessibleNoteField = value;
            }
        }

        /// <remarks/>
        public string MLAK
        {
            get
            {
                return this.mLAKField;
            }
            set
            {
                this.mLAKField = value;
            }
        }

        /// <remarks/>
        public string ParkingAccessible
        {
            get
            {
                return this.parkingAccessibleField;
            }
            set
            {
                this.parkingAccessibleField = value;
            }
        }

        /// <remarks/>
        public string AccessibleParkingNote
        {
            get
            {
                return this.accessibleParkingNoteField;
            }
            set
            {
                this.accessibleParkingNoteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    public partial class ToiletMapExportToiletDetailsOpeningHours
    {

        private string isOpenField;

        private string openingHoursScheduleField;

        private string openingHoursNoteField;

        /// <remarks/>
        public string IsOpen
        {
            get
            {
                return this.isOpenField;
            }
            set
            {
                this.isOpenField = value;
            }
        }

        /// <remarks/>
        public string OpeningHoursSchedule
        {
            get
            {
                return this.openingHoursScheduleField;
            }
            set
            {
                this.openingHoursScheduleField = value;
            }
        }

        /// <remarks/>
        public string OpeningHoursNote
        {
            get
            {
                return this.openingHoursNoteField;
            }
            set
            {
                this.openingHoursNoteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    public partial class ToiletMapExportToiletDetailsFeatures
    {

        private string babyChangeField;

        private string showersField;

        private string drinkingWaterField;

        private string sharpsDisposalField;

        private string sanitaryDisposalField;

        /// <remarks/>
        public string BabyChange
        {
            get
            {
                return this.babyChangeField;
            }
            set
            {
                this.babyChangeField = value;
            }
        }

        /// <remarks/>
        public string Showers
        {
            get
            {
                return this.showersField;
            }
            set
            {
                this.showersField = value;
            }
        }

        /// <remarks/>
        public string DrinkingWater
        {
            get
            {
                return this.drinkingWaterField;
            }
            set
            {
                this.drinkingWaterField = value;
            }
        }

        /// <remarks/>
        public string SharpsDisposal
        {
            get
            {
                return this.sharpsDisposalField;
            }
            set
            {
                this.sharpsDisposalField = value;
            }
        }

        /// <remarks/>
        public string SanitaryDisposal
        {
            get
            {
                return this.sanitaryDisposalField;
            }
            set
            {
                this.sanitaryDisposalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://toiletmap.gov.au/")]
    public partial class ToiletMapExportToiletDetailsIcon
    {

        private string iconURLField;

        private string iconAltTextField;

        /// <remarks/>
        public string IconURL
        {
            get
            {
                return this.iconURLField;
            }
            set
            {
                this.iconURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IconAltText
        {
            get
            {
                return this.iconAltTextField;
            }
            set
            {
                this.iconAltTextField = value;
            }
        }
    }
}
