namespace SayugaSol.Default {
    export interface EmployeeRow {
        Id?: number;
        LastName?: string;
        FirstName?: string;
        Title?: string;
        FullName?: string;
        Dob?: string;
        HireDate?: string;
        Address?: string;
        City?: string;
        Region?: string;
        PostalCode?: string;
        Country?: string;
        Email?: string;
        Phone1?: string;
        Phone1Type?: number;
        Phone2?: string;
        Phone2Type?: number;
        Notes?: string;
        ReportsTo?: number;
        Photo?: string;
        PhotoPath?: string;
        SkillId?: number;
        CertificationId?: number;
        skillName?: string;
        certName?: string;
    }

    export namespace EmployeeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'LastName';
        export const localTextPrefix = 'Default.Employee';
        export const lookupKey = 'Default.Employee';

        export function getLookup(): Q.Lookup<EmployeeRow> {
            return Q.getLookup<EmployeeRow>('Default.Employee');
        }

        export declare const enum Fields {
            Id = "Id",
            LastName = "LastName",
            FirstName = "FirstName",
            Title = "Title",
            FullName = "FullName",
            Dob = "Dob",
            HireDate = "HireDate",
            Address = "Address",
            City = "City",
            Region = "Region",
            PostalCode = "PostalCode",
            Country = "Country",
            Email = "Email",
            Phone1 = "Phone1",
            Phone1Type = "Phone1Type",
            Phone2 = "Phone2",
            Phone2Type = "Phone2Type",
            Notes = "Notes",
            ReportsTo = "ReportsTo",
            Photo = "Photo",
            PhotoPath = "PhotoPath",
            SkillId = "SkillId",
            CertificationId = "CertificationId",
            skillName = "skillName",
            certName = "certName"
        }
    }
}

