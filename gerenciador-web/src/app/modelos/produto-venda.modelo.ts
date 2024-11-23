import { Produto } from "./produto.modelo";

export class ProdutoVenda {
    produto: Produto;
    quantidade: number;

    public get total(): number{
        return this.produto.valorVenda * this.quantidade;
    }

    constructor(produto: Produto, quantidade: number){
        this.produto = produto;
        this.quantidade = quantidade;
    }    
}
