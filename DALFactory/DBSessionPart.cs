using DAL;
using IDAL;

namespace DALFactory
{
    public partial class DBSession
    {

        
        private IBDTA_INSPECT_STANDARDDal _BDTA_INSPECT_STANDARDDal;

        public IBDTA_INSPECT_STANDARDDal BDTA_INSPECT_STANDARDDal
        {
            get
            {
                if (_BDTA_INSPECT_STANDARDDal == null)
                {
                    _BDTA_INSPECT_STANDARDDal = Create<BDTA_INSPECT_STANDARDDal>("BDTA_INSPECT_STANDARDDal");
                }
                return _BDTA_INSPECT_STANDARDDal;
            }
            set { _BDTA_INSPECT_STANDARDDal = value; }
        }

        private IBDTA_INSPECT_STANDARD_DETAILDal _BDTA_INSPECT_STANDARD_DETAILDal;

        public IBDTA_INSPECT_STANDARD_DETAILDal BDTA_INSPECT_STANDARD_DETAILDal
        {
            get
            {
                if (_BDTA_INSPECT_STANDARD_DETAILDal == null)
                {
                    _BDTA_INSPECT_STANDARD_DETAILDal = Create<BDTA_INSPECT_STANDARD_DETAILDal>("BDTA_INSPECT_STANDARD_DETAILDal");
                }
                return _BDTA_INSPECT_STANDARD_DETAILDal;
            }
            set { _BDTA_INSPECT_STANDARD_DETAILDal = value; }
        }

        private IBDTA_PARTNERDal _BDTA_PARTNERDal;

        public IBDTA_PARTNERDal BDTA_PARTNERDal
        {
            get
            {
                if (_BDTA_PARTNERDal == null)
                {
                    _BDTA_PARTNERDal = Create<BDTA_PARTNERDal>("BDTA_PARTNERDal");
                }
                return _BDTA_PARTNERDal;
            }
            set { _BDTA_PARTNERDal = value; }
        }

        private IPLAN_JOBDISPATCHDal _PLAN_JOBDISPATCHDal;

        public IPLAN_JOBDISPATCHDal PLAN_JOBDISPATCHDal
        {
            get
            {
                if (_PLAN_JOBDISPATCHDal == null)
                {
                    _PLAN_JOBDISPATCHDal = Create<PLAN_JOBDISPATCHDal>("PLAN_JOBDISPATCHDal");
                }
                return _PLAN_JOBDISPATCHDal;
            }
            set { _PLAN_JOBDISPATCHDal = value; }
        }

        private IBDTA_SETUPDal _BDTA_SETUPDal;

        public IBDTA_SETUPDal BDTA_SETUPDal
        {
            get
            {
                if (_BDTA_SETUPDal == null)
                {
                    _BDTA_SETUPDal = Create<BDTA_SETUPDal>("BDTA_SETUPDal");
                }
                return _BDTA_SETUPDal;
            }
            set { _BDTA_SETUPDal = value; }
        }

        private IPO_WORKORDERDal _PO_WORKORDERDal;

        public IPO_WORKORDERDal PO_WORKORDERDal
        {
            get
            {
                if (_PO_WORKORDERDal == null)
                {
                    _PO_WORKORDERDal = Create<PO_WORKORDERDal>("PO_WORKORDERDal");
                }
                return _PO_WORKORDERDal;
            }
            set { _PO_WORKORDERDal = value; }
        }

        private IQA_INSPECT_BILLDal _QA_INSPECT_BILLDal;

        public IQA_INSPECT_BILLDal QA_INSPECT_BILLDal
        {
            get
            {
                if (_QA_INSPECT_BILLDal == null)
                {
                    _QA_INSPECT_BILLDal = Create<QA_INSPECT_BILLDal>("QA_INSPECT_BILLDal");
                }
                return _QA_INSPECT_BILLDal;
            }
            set { _QA_INSPECT_BILLDal = value; }
        }

        private IQA_INSPECT_BILL_DETAILDal _QA_INSPECT_BILL_DETAILDal;

        public IQA_INSPECT_BILL_DETAILDal QA_INSPECT_BILL_DETAILDal
        {
            get
            {
                if (_QA_INSPECT_BILL_DETAILDal == null)
                {
                    _QA_INSPECT_BILL_DETAILDal = Create<QA_INSPECT_BILL_DETAILDal>("QA_INSPECT_BILL_DETAILDal");
                }
                return _QA_INSPECT_BILL_DETAILDal;
            }
            set { _QA_INSPECT_BILL_DETAILDal = value; }
        }

        private ISALESORDERDal _SALESORDERDal;

        public ISALESORDERDal SALESORDERDal
        {
            get
            {
                if (_SALESORDERDal == null)
                {
                    _SALESORDERDal = Create<SALESORDERDal>("SALESORDERDal");
                }
                return _SALESORDERDal;
            }
            set { _SALESORDERDal = value; }
        }


    }
}