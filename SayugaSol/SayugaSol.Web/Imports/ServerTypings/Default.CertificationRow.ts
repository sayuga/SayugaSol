namespace SayugaSol.Default {
    export interface CertificationRow {
        Id?: number;
        Name?: string;
        Description?: string;
        DateAcquired?: string;
        ExpirationDate?: string;
    }

    export namespace CertificationRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.Certification';
        export const lookupKey = 'Default.Certification';

        export function getLookup(): Q.Lookup<CertificationRow> {
            return Q.getLookup<CertificationRow>('Default.Certification');
        }

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            DateAcquired = "DateAcquired",
            ExpirationDate = "ExpirationDate"
        }
    }
}

