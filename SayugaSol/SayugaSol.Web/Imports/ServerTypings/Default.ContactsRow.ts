namespace SayugaSol.Default {
    export interface ContactsRow {
        Id?: number;
        LastName?: string;
        FirstName?: string;
        Title?: string;
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
        CompanyName?: string;
    }

    export namespace ContactsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'LastName';
        export const localTextPrefix = 'Default.Contacts';

        export declare const enum Fields {
            Id = "Id",
            LastName = "LastName",
            FirstName = "FirstName",
            Title = "Title",
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
            CompanyName = "CompanyName"
        }
    }
}

