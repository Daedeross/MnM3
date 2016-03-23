using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnMBuilder.DataModels
{
    public class Ability : BaseTrait
    {
        #region Private Fields

        #endregion // Private fields

        #region Properties

        public int Level { get; set; }

        public override bool IsValid
        {
            get
            {
                return Level <= 10 + PL;
            }
        }

        #endregion // Properties

        #region Constructors

        public Ability()
        {

        }

        public Ability(MM3Character owner)
            : base(owner)
        {
        }

        #endregion // Constructors
        
        #region Private Methods

        #endregion // Private Methods

        #region Public Methods

        #endregion // Public Methods
    }
}
