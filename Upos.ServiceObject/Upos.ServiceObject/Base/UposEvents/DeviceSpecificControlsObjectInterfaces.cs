﻿using System.Runtime.InteropServices;

namespace Upos.ServiceObject.Base.UposEvents
{
    /*
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface BeltControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface BillAcceptorControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface BillDispenserControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface BiometricsControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface BumpBarControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface CATControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface CashChangerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface CashDrawerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface CheckScannerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface CoinAcceptorControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface CoinDispenserControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ElectronicJournalControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ElectronicValueRWControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface FiscalPrinterControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface GateControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface HardTotalsControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ImageScannerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ItemDispenserControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface KeylockControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface LightsControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface LineDisplayControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface MICRControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface MotionSensorControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface PINPadControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface POSKeyboardControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface POSPowerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface POSPrinterControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface PointCardRWControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface RFIDScannerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface RemoteOrderDisplayControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ScaleControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ScannerControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface SignatureCaptureControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface SmartCardRWControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB9xxxx-B81E-11D2-AB74-0040054C3719")]internal interface ToneIndicatorControlObject{[DispId(1)]void SOData(int Status);[DispId(2)]void SODirectIO(int EventNumber, ref int pData, ref string pString);[DispId(3)]void SOError(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse);[DispId(4)]void SOOutputCompleteDummy(int OutputID);[DispId(5)]void SOStatusUpdate(int Data);}
     */
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("CCB91121-B81E-11D2-AB74-0040054C3719")]/*CCB90123-B81E-11D2-AB74-0040054C3719   <-- This one is the IOpos Event.. i wanna try it*/
    internal interface MsrControlObject
    {
        [DispId(1)]
        void SOData(int status);

        [DispId(2)]
        void SODirectIO(int eventNumber, ref int pData, ref string pString);

        [DispId(3)]
        void SOError(int resultCode, int resultCodeExtended, int errorLocus, ref int pErrorResponse);

        [DispId(4)]
        void SOOutputCompleteDummy(int outputId);

        [DispId(5)]
        void SOStatusUpdate(int data);
    }
}
