using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MnMBuilder.DataModels
{
    public abstract class BaseTrait: DataModelBase, ITrait
    {
        #region Private Fields

        protected MM3Character owner;

        #endregion // Private fields

        #region Properties

        public abstract bool IsValid { get; }

        protected int PL { get { return PowerLevel(); } }

        #endregion // Properties

        #region Constructors

        public BaseTrait()
        {
            
        }

        public BaseTrait(MM3Character owner)
        {
            this.owner = owner;
        }

        #endregion // Constructors

        #region Private Methods

        protected int PowerLevel()
        {
            if (owner != null)
                return owner.PowerLevel;
            else return 0;
        }

        #endregion // Private Methods

        #region Public Methods

        #endregion // Public Methods
    }
}
