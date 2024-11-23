export interface Produto {
    id: number;
    criadoEm: Date;
    atualizadoEm: Date;
    codigoBarras: string;
    nome: string;
    valorVenda: number;
    valorCompra: number;
    percentualImposto: number;
    foto: string;
    categoriaId: number;
    categoriaNome: string;
}
