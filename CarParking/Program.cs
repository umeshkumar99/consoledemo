using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CarParking
{
    class Program
    {
        static void Main(string[] args)
        {

            ParkingLot objParkingLot = ParkingLotUtility.CreateSampleParkingLot();

            Console.WriteLine("Please enter the Vehicle: Motorcycle - 1, Car - 2, Bus - 3");
            Console.WriteLine("At anytime type 'y' and press enter to exit");
            string strUserInput = Convert.ToString(Console.ReadLine());
            int intVehicleNumber;

            while (strUserInput != "y")
            {
                intVehicleNumber = Convert.ToInt32(strUserInput);

                ManageParking(intVehicleNumber, ref objParkingLot);

                Console.WriteLine();
                Console.WriteLine("Please enter the Vehicle: Motorcycle - 1, Car - 2, Bus - 3");
                Console.WriteLine("At anytime type 'y' and press enter to exit");
                strUserInput = Convert.ToString(Console.ReadLine());
            }
        }

        private static void ManageParking(int vehicleNumber, ref ParkingLot parkingLot)
        {
            if (vehicleNumber == 1)
            {
                Motorcycle objMotorcycle = new Motorcycle();
                objMotorcycle.ManageParking(ref parkingLot);

                WriteOutput(objMotorcycle.IsParkingAvailable, Convert.ToString(objMotorcycle.VehicleName), objMotorcycle.VehicleParkingInformation);
            }
            else if (vehicleNumber == 2)
            {

            }
            else if (vehicleNumber == 3)
            {
            }
        }

        private static void WriteOutput(bool isParkingAvailable, string vehicleName, VehicleParkingInformation vehicleParkingInformation)
        {
            if (isParkingAvailable == true)
            {
                Console.WriteLine("Parking done successfully for the " + vehicleName + "! The parking has been done at below parking spot:");
                Console.WriteLine("Level - " + vehicleParkingInformation.LevelNumber + ", Row - " + vehicleParkingInformation.RowNumber
                                  + ", Spot(s) - " + String.Join(",", vehicleParkingInformation.SpotNumbers) + ", Spot Type - " + vehicleParkingInformation.SpotType);
            }
            else
            {
                Console.WriteLine("No Parking available for " + vehicleName);
            }
        }
    }
}




public static class ParkingLotConstants
{
    public const int LevelCount = 10;
    public const int RowCount = 20;
    public const int MotorcycleSpotOnlyRowCount = 5;
    public const int MotorcycleSpotOnlySpotCount = 50;
    public const int MixedSpotsSpotCount = 35;
    public const int MixedSpotsMotorcycleSpotCount = 10;
    public const int MixedSpotsCompactSpotCount = 15;
    public const int MixedSpotsLargeSpotCount = 10;

    public enum ParkingSpotType { MotorcycleSpot, CompactSpot, LargeSpot };
    public enum VehicleName { Motorcycle, Car, Bus };
}




public class ParkingSpot
{
    public int LevelNumber { get; set; }

    public int RowNumber { get; set; }

    public int SpotNumber { get; set; }

    public ParkingLotConstants.ParkingSpotType SpotType { get; set; }

    public bool IsFilled { get; set; }
}



public class ParkingRow
{
    public int LevelNumber { get; set; }

    public int RowNumber { get; set; }

    public List<ParkingSpot> ParkingSpots { get; set; }
}

public class ParkingLevel
{
    public int LevelNumber { get; set; }

    public List<ParkingRow> ParkingRows { get; set; }
}
public class ParkingLot
{
    public List<ParkingLevel> ParkingLevels { get; set; }
}

public class VehicleParkingInformation
{
    public int LevelNumber { get; set; }

    public int RowNumber { get; set; }

    public List<int> SpotNumbers { get; set; }

    public ParkingLotConstants.ParkingSpotType SpotType { get; set; }
}



public abstract class Vehicle
{
    public bool IsParkingAvailable { get; set; }

    public VehicleParkingInformation VehicleParkingInformation { get; set; }

    public ParkingLotConstants.VehicleName VehicleName { get; set; }

    public abstract void ManageParking(ref ParkingLot parkingLot);
}


//class to get parking information
public static class VehicleUtility
{
    public static VehicleParkingInformation GetVehicleParkingInformation(int parkingLevelNumber, int parkingRowNumber, List<int> parkingSpotNumbers, ParkingLotConstants.ParkingSpotType parkingSpotType)
    {
        return new VehicleParkingInformation { LevelNumber = parkingLevelNumber, RowNumber = parkingRowNumber, SpotNumbers = parkingSpotNumbers, SpotType = parkingSpotType };
    }
}


public static class ParkingLotUtility
{


    //FUNCTION TO CREATE SAMPLE PAKING LEVELS
    public static ParkingLevel CreateSampleParkingLevel(int levelNumber, List<ParkingRow> parkingRows)
    {
        return new ParkingLevel { LevelNumber = levelNumber, ParkingRows = parkingRows };
    }

    public static ParkingSpot CreateSampleParkingSpot(int levelNumber, int rowNumber, int spotNumber, ParkingLotConstants.ParkingSpotType spotType, bool isFilled)
    {
        return new ParkingSpot { LevelNumber = levelNumber, RowNumber = rowNumber, SpotNumber = spotNumber, SpotType = spotType, IsFilled = isFilled };
    }

    public static List<ParkingSpot> CreateSample1ParkingSpotList(int levelNumber, int rowNumber)
    {
        List<ParkingSpot> lstSample1ParkingSpot = new List<ParkingSpot>();

        for (int i = 1; i <= ParkingLotConstants.MotorcycleSpotOnlySpotCount; i++)
        {
            ParkingSpot objSample1ParkingSpot = CreateSampleParkingSpot(levelNumber, rowNumber, i, ParkingLotConstants.ParkingSpotType.MotorcycleSpot, false);

            lstSample1ParkingSpot.Add(objSample1ParkingSpot);
        }

        return lstSample1ParkingSpot;
    }

    public static List<ParkingSpot> CreateSample2ParkingSpotList(int levelNumber, int rowNumber)
    {
        List<ParkingSpot> lstSample2ParkingSpot = new List<ParkingSpot>();
        int MixedSpotMotorcycleSpotLastSpotNumber = ParkingLotConstants.MixedSpotsMotorcycleSpotCount;
        int MixedSpotCompactSpotLastSpotNumber = ParkingLotConstants.MixedSpotsMotorcycleSpotCount + ParkingLotConstants.MixedSpotsCompactSpotCount;

        for (int i = 1; i <= ParkingLotConstants.MixedSpotsSpotCount; i++)
        {
            ParkingLotConstants.ParkingSpotType parkingSpotType = ParkingLotConstants.ParkingSpotType.MotorcycleSpot;

            if (i <= MixedSpotMotorcycleSpotLastSpotNumber)
            {
                parkingSpotType = ParkingLotConstants.ParkingSpotType.MotorcycleSpot;
            }
            else if (i > MixedSpotMotorcycleSpotLastSpotNumber && i <= MixedSpotCompactSpotLastSpotNumber)
            {
                parkingSpotType = ParkingLotConstants.ParkingSpotType.CompactSpot;
            }
            else if (i > MixedSpotCompactSpotLastSpotNumber)
            {
                parkingSpotType = ParkingLotConstants.ParkingSpotType.LargeSpot;
            }

            ParkingSpot objSample2ParkingSpot = CreateSampleParkingSpot(levelNumber, rowNumber, i, parkingSpotType, false);

            lstSample2ParkingSpot.Add(objSample2ParkingSpot);
        }

        return lstSample2ParkingSpot;
    }

    public static ParkingRow CreateSampleParkingRow(int levelNumber, int rowNumber, List<ParkingSpot> parkingSpots)
    {
        return new ParkingRow { LevelNumber = levelNumber, RowNumber = rowNumber, ParkingSpots = parkingSpots };
    }

    // FUNCTION TO CREATE SAMPLE ROWS
    public static List<ParkingRow> CreateSampleParkingRowList(int levelNumber)
    {
        List<ParkingRow> lstSampleParkingRow = new List<ParkingRow>();
        int MotorcycleSpotOnlyLastRowNumber = ParkingLotConstants.MotorcycleSpotOnlyRowCount;

        for (int i = 1; i <= ParkingLotConstants.RowCount; i++)
        {
            ParkingRow objParkingRow = new ParkingRow();

            List<ParkingSpot> lstSample1ParkingSpot = CreateSample1ParkingSpotList(levelNumber, i);
            List<ParkingSpot> lstSample2ParkingSpot = CreateSample2ParkingSpotList(levelNumber, i);

            if (i <= MotorcycleSpotOnlyLastRowNumber)
            {
                objParkingRow = CreateSampleParkingRow(levelNumber, i, lstSample1ParkingSpot);
            }
            else if (i > MotorcycleSpotOnlyLastRowNumber)
            {
                objParkingRow = CreateSampleParkingRow(levelNumber, i, lstSample2ParkingSpot);
            }

            lstSampleParkingRow.Add(objParkingRow);
        }

        return lstSampleParkingRow;
    }



   
   
   
    public static ParkingLot CreateSampleParkingLot()
    {
        List<ParkingLevel> lstSampleParkingLevel = new List<ParkingLevel>();

        for (int i = 0; i <= ParkingLotConstants.LevelCount; i++)
        {
            List<ParkingRow> lstSampleParkingRow = CreateSampleParkingRowList(i);

            ParkingLevel objSampleParkingLevel = CreateSampleParkingLevel(i, lstSampleParkingRow);

            lstSampleParkingLevel.Add(objSampleParkingLevel);
        }

        ParkingLot objSampleParkingLot = new ParkingLot();
        objSampleParkingLot.ParkingLevels = lstSampleParkingLevel;

        return objSampleParkingLot;
    }

   
}



public class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        IsParkingAvailable = false;
        VehicleName = ParkingLotConstants.VehicleName.Motorcycle;
    }

    private void CheckForParkingAvailability(ParkingLot parkingLot)
    {
        List<ParkingLevel> lstParkingLevel = parkingLot.ParkingLevels;
        int MotorcycleSpotOnlyLastRowNumber = ParkingLotConstants.MotorcycleSpotOnlyRowCount;
        int MixedSpotMotorcycleSpotLastSpotNumber = ParkingLotConstants.MixedSpotsMotorcycleSpotCount;

        for (int i = 0; i <= lstParkingLevel.Count - 1; i++)
        {
            ParkingLevel objParkingLevel = lstParkingLevel[i];
            List<ParkingRow> lstParkingRow = objParkingLevel.ParkingRows;

            for (int j = 0; j <= lstParkingRow.Count - 1; j++)
            {
                ParkingRow objParkingRow = lstParkingRow[j];
                List<ParkingSpot> lstParkingSpot = objParkingRow.ParkingSpots;

                for (int k = 0; k <= lstParkingSpot.Count - 1; k++)
                {
                    ParkingSpot objParkingSpot = lstParkingSpot[k];
                    bool isFilled = objParkingSpot.IsFilled;

                    if (j <= (MotorcycleSpotOnlyLastRowNumber - 1))
                    {
                        if (isFilled == false)
                        {
                            IsParkingAvailable = true;
                            VehicleParkingInformation = VehicleUtility.GetVehicleParkingInformation(objParkingSpot.LevelNumber, objParkingSpot.RowNumber, new List<int> { objParkingSpot.SpotNumber }, objParkingSpot.SpotType);
                            break;
                        }
                    }
                    else if (j > (MotorcycleSpotOnlyLastRowNumber - 1))
                    {
                        if (k <= (MixedSpotMotorcycleSpotLastSpotNumber - 1))
                        {
                            if (isFilled == false)
                            {
                                IsParkingAvailable = true;
                                VehicleParkingInformation = VehicleUtility.GetVehicleParkingInformation(objParkingSpot.LevelNumber, objParkingSpot.RowNumber, new List<int> { objParkingSpot.SpotNumber }, objParkingSpot.SpotType);
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (IsParkingAvailable == true)
                {
                    break;
                }
            }


        }
    }

    private void DoMotorcycleParking(ref ParkingLot parkingLot)
    {
        int intTargetLevelNumber = VehicleParkingInformation.LevelNumber;
        int intTargetRowNumber = VehicleParkingInformation.RowNumber;
        int intTargetSpotNumber = VehicleParkingInformation.SpotNumbers[0];

        ParkingLevel objTargetParkingLevel = parkingLot.ParkingLevels[intTargetLevelNumber];

        ParkingRow objTargetParkingRow = objTargetParkingLevel.ParkingRows[intTargetRowNumber - 1];

        ParkingSpot objTargetParkingSpot = objTargetParkingRow.ParkingSpots[intTargetSpotNumber - 1];
        objTargetParkingSpot.IsFilled = true;
    }

    public override void ManageParking(ref ParkingLot parkingLot)
    {
        CheckForParkingAvailability(parkingLot);

        if (IsParkingAvailable == true)
        {
            DoMotorcycleParking(ref parkingLot);
        }
    }

  
}






    public class Car : Vehicle
    {
        public Car()
        {
            IsParkingAvailable = false;
            VehicleName =ParkingLotConstants.VehicleName.Car;
        }

        public override void ManageParking(ref ParkingLot parkingLot)
        {
            CheckForParkingAvailability(parkingLot);

            if (IsParkingAvailable == true)
            {
                DoCarParking(ref parkingLot);
            }
        }

    private void CheckForParkingAvailability(ParkingLot parkingLot)
    {
        List<ParkingLevel> lstParkingLevel = parkingLot.ParkingLevels;
        int MotorcycleSpotOnlyLastRowNumber = ParkingLotConstants.MotorcycleSpotOnlyRowCount;
        int MixedSpotMotorcycleSpotLastSpotNumber = ParkingLotConstants.MixedSpotsMotorcycleSpotCount;

        for (int i = 0; i <= lstParkingLevel.Count; i++)
        {
            ParkingLevel objParkingLevel = lstParkingLevel[i];
            List<ParkingRow> lstParkingRow = objParkingLevel.ParkingRows;

            for (int j = MotorcycleSpotOnlyLastRowNumber; j <= lstParkingRow.Count - 1; j++)
            {
                ParkingRow objParkingRow = lstParkingRow[j];
                List<ParkingSpot> lstParkingSpot = objParkingRow.ParkingSpots;

                for (int k = MixedSpotMotorcycleSpotLastSpotNumber; k <= lstParkingSpot.Count - 1; k++)
                {
                    ParkingSpot objParkingSpot = lstParkingSpot[k];
                    bool isFilled = objParkingSpot.IsFilled;

                    if (isFilled == false)
                    {
                        IsParkingAvailable = true;
                        VehicleParkingInformation = VehicleUtility.GetVehicleParkingInformation(objParkingSpot.LevelNumber, objParkingSpot.RowNumber, new List<int> { objParkingSpot.SpotNumber }, objParkingSpot.SpotType);
                        break;
                    }
                }

                if (IsParkingAvailable == true)
                {
                    break;
                }
            }

            if (IsParkingAvailable == true)
            {
                break;
            }
        }
    }
       

        private void DoCarParking(ref ParkingLot parkingLot)
        {
            int intTargetLevelNumber = VehicleParkingInformation.LevelNumber;
            int intTargetRowNumber = VehicleParkingInformation.RowNumber;
            int intTargetSpotNumber = VehicleParkingInformation.SpotNumbers[0];

            ParkingLevel objTargetParkingLevel = parkingLot.ParkingLevels[intTargetLevelNumber];

            ParkingRow objTargetParkingRow = objTargetParkingLevel.ParkingRows[intTargetRowNumber - 1];

            ParkingSpot objTargetParkingSpot = objTargetParkingRow.ParkingSpots[intTargetSpotNumber - 1];
            objTargetParkingSpot.IsFilled = true;
        }
    }


    public class Bus : Vehicle
    {
        public Bus()
        {
            IsParkingAvailable = false;
            VehicleName =ParkingLotConstants.VehicleName.Bus;
        }

        public override void ManageParking(ref ParkingLot parkingLot)
        {
            CheckForParkingAvailability(parkingLot);

            if (IsParkingAvailable == true)
            {
                DoBusParking(ref parkingLot);
            }
        }

    private void CheckForParkingAvailability(ParkingLot parkingLot)
    {
        List<ParkingLevel> lstParkingLevel = parkingLot.ParkingLevels;
        int MotorcycleSpotOnlyLastRowNumber = ParkingLotConstants.MotorcycleSpotOnlyRowCount;
        int MixedSpotCompactSpotLastSpotNumber = ParkingLotConstants.MixedSpotsMotorcycleSpotCount + ParkingLotConstants.MixedSpotsCompactSpotCount;

        for (int i = 0; i <= lstParkingLevel.Count; i++)
        {
            ParkingLevel objParkingLevel = lstParkingLevel[i];
            List<ParkingRow> lstParkingRow = objParkingLevel.ParkingRows;

            for (int j = MotorcycleSpotOnlyLastRowNumber; j <= lstParkingRow.Count - 1; j++)
            {
                ParkingRow objParkingRow = lstParkingRow[j];
                List<ParkingSpot> lstParkingSpot = objParkingRow.ParkingSpots;
                int intConsecutiveFiveSpotsCount = 0;
                List<int> lstConsecutiveFiveSpots = new List<int>();

                for (int k = MixedSpotCompactSpotLastSpotNumber; k <= lstParkingSpot.Count - 1; k++)
                {
                    ParkingSpot objParkingSpot = lstParkingSpot[k];
                    bool isFilled = objParkingSpot.IsFilled;

                    if (isFilled == false)
                    {
                        intConsecutiveFiveSpotsCount++;
                        lstConsecutiveFiveSpots.Add(objParkingSpot.SpotNumber);
                    }
                    else if (isFilled == true)
                    {
                        intConsecutiveFiveSpotsCount = 0;
                        lstConsecutiveFiveSpots.Clear();
                    }

                    if (intConsecutiveFiveSpotsCount == 5)
                    {
                        IsParkingAvailable = true;
                        VehicleParkingInformation = VehicleUtility.GetVehicleParkingInformation(objParkingSpot.LevelNumber, objParkingSpot.RowNumber, lstConsecutiveFiveSpots, objParkingSpot.SpotType);
                        break;
                    }
                }

                if (IsParkingAvailable == true)
                {
                    break;
                }
            }

            if (IsParkingAvailable == true)
            {
                break;
            }
        }
    }
        
        private void DoBusParking(ref ParkingLot parkingLot)
        {
            int intTargetLevelNumber = VehicleParkingInformation.LevelNumber;
            int intTargetRowNumber = VehicleParkingInformation.RowNumber;
            List<int> lstTargetSpotNumber = VehicleParkingInformation.SpotNumbers;

            ParkingLevel objTargetParkingLevel = parkingLot.ParkingLevels[intTargetLevelNumber];

            ParkingRow objTargetParkingRow = objTargetParkingLevel.ParkingRows[intTargetRowNumber - 1];

            List<ParkingSpot> lstTargetParkingSpot = objTargetParkingRow.ParkingSpots.
                                                        FindAll(x => (x.SpotNumber >= lstTargetSpotNumber[0] && x.SpotNumber <= lstTargetSpotNumber[lstTargetSpotNumber.Count - 1]));
            foreach (ParkingSpot parkingSpot in lstTargetParkingSpot)
            {
                parkingSpot.IsFilled = true;
            }
        }
    }





