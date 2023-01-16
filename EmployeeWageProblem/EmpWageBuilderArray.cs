﻿using System;
public class EmpWageBuilder : IComputeEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

    public EmpWageBuilder()
    {
        this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }

    public void addCompanyEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyname, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
        this.companyEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(companyname, companyEmpWage);
    }

    public void computeEmpWage()
    {
        foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
        {
            companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
            Console.WriteLine(companyEmpWage.toString());
        }
    }

    private int computeEmpWage(CompanyEmpWage companyEmpWage)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
        }
        return totalEmpHrs * companyEmpWage.empRatePerHour;
    }

    public int getTotalWage(string companyname)
    {
        return this.companyToEmpWageMap[companyname].totalEmpWage;
    }
}
    }
}
