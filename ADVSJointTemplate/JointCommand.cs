using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using Autodesk.AdvanceSteel.CADLink.Database;
using Autodesk.AdvanceSteel.Geometry;
using AstSTEELAUTOMATIONLib;

namespace ADVSJointTemplate
{
    // [ComVisible(true)]
    // [Guid("insert new GUID here and comment out this and the previous line")]
    class JointCommand : IRule, IJointInfo
    {
        // constructor
        public JointCommand() { }

        #region IRuleInterface

        public Joint Joint
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Query (AstUI pAstUI)
        {
            throw new NotImplementedException();
        }

        public void InField (IFiler pFiler)
        {
            throw new NotImplementedException();
        }

        public void OutField (IFiler pFiler)
        {
            throw new NotImplementedException();
        }

        public string GetTableName ()
        {
            throw new NotImplementedException();
        }

        public void CreateObjects ()
        {
            throw new NotImplementedException();
        }

        public void GetUserPages (RulePageArray pagesRet, PropertySheetData pPropSheetData)
        {
            throw new NotImplementedException();
        }

        public void FreeUserPages ()
        {
            throw new NotImplementedException();
        }

        public void GetExportData (IRuleExportFiler pExportFiler)
        {
            throw new NotImplementedException();
        }

        public bool GetFeatureName (ref string FeatureName)
        {
            throw new NotImplementedException();
        }

        public void InvalidFeature (int reserved)
        {
            throw new NotImplementedException();
        }

        public bool ConvertFromHRL (HRLConvertFiler filer, string OldHRLRuleName)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJointInfo interface

        public string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ASVersion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string CompName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Email
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int LogoIconId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string VersionNumber
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
