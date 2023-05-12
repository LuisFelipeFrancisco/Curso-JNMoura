export class Medico{
    public Codigo!: number;
    public Nome: string;
    public DataNascimento: string;
    public Crm: string;

    constructor(){
        this.Nome = "";
        this.DataNascimento = "";
        this.Crm = "";
    }
}