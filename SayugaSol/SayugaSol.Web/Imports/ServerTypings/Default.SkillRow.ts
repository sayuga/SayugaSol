namespace SayugaSol.Default {
    export interface SkillRow {
        Id?: number;
        Name?: string;
        Description?: string;
    }

    export namespace SkillRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.Skill';
        export const lookupKey = 'Default.Skill';

        export function getLookup(): Q.Lookup<SkillRow> {
            return Q.getLookup<SkillRow>('Default.Skill');
        }

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description"
        }
    }
}

