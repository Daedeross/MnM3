using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnMBuilder.DataModels
{
    public class MM3Character: DataModelBase
    {
        #region Private Fields

        #endregion // Private fields

        #region Properties

            #region Background / Appearance

        private string mPlayer;
        public string Player
        {
            get { return mPlayer; }
            set
            {
                if (value != mPlayer)
                {
                    mPlayer = value;
                    OnPropertyChanged("Player");
                }
            }
        }
        
        private string mIdentity;
        public string Identity
        {
            get { return mIdentity; }
            set
            {
                if (value != mIdentity)
                {
                    mIdentity = value;
                    OnPropertyChanged("Identity");
                }
            }
        }

        private bool mIdentitySecret;
        public bool IdentitySecret
        {
            get { return mIdentitySecret; }
            set
            {
                if (value != mIdentitySecret)
                {
                    mIdentitySecret = value;
                    OnPropertyChanged("IdentitySecret");
                }
            }
        }

        private string mGender;
        public string Gender
        {
            get { return mGender; }
            set
            {
                if (value != mGender)
                {
                    mGender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }

        private string mAge;
        public string Age
        {
            get { return mAge; }
            set
            {
                if (value != mAge)
                {
                    mAge = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        private string mHeight;
        public string Height
        {
            get { return mHeight; }
            set
            {
                if (value != mHeight)
                {
                    mHeight = value;
                    OnPropertyChanged("Height");
                }
            }
        }

        private string mWeight;
        public string Weight
        {
            get { return mWeight; }
            set
            {
                if (value != mWeight)
                {
                    mWeight = value;
                    OnPropertyChanged("Weight");
                }
            }
        }

        private string mEyes;
        public string Eyes
        {
            get { return mEyes; }
            set
            {
                if (value != mEyes)
                {
                    mEyes = value;
                    OnPropertyChanged("Eyes");
                }
            }
        }

        private string mHair;
        public string Hear
        {
            get { return mHair; }
            set
            {
                if (value != mHair)
                {
                    mHair = value;
                    OnPropertyChanged("Hear");
                }
            }
        }

        private string mGroupAffiliation;
        public string GroupAffiliation
        {
            get { return mGroupAffiliation; }
            set
            {
                if (value != mGroupAffiliation)
                {
                    mGroupAffiliation = value;
                    OnPropertyChanged("GroupAffiliation'");
                }
            }
        }

        private string mBaseOfOperations;
        public string BaseOfOperations
        {
            get { return mBaseOfOperations; }
            set
            {
                if (value != mBaseOfOperations)
                {
                    mBaseOfOperations = value;
                    OnPropertyChanged("BaseOfOperations");
                }
            }
        }

        private int mPowerLevel;
        public int PowerLevel
        {
            get { return mPowerLevel; }
            set
            {
                if (value != mPowerLevel)
                {
                    mPowerLevel = value;
                    OnPropertyChanged("PowerLevel");
                }
            }
        }

        #endregion // Background / Appearance

            #region Abilities



            #endregion // Abilities

            #region Defense



            #endregion // Defense

            #region Offense

            #endregion // Offense



            #endregion // Properties

        #region Constructors

        #endregion // Constructors

        #region Private Methods

        #endregion // Private Methods

        #region Public Methods

        #endregion // Public Methods
    }
}
