export interface Perfil {
    nome: string;
    id: number;
    criadoEm: Date;
    atualizadoEm: Date;
}

export interface User {
    nome: string;
    email: string;
    perfilId: number;
    senha: string;
    perfil: Perfil;
    id: number;
    criadoEm: Date;
    atualizadoEm: Date;
}

export interface LoginResultado {
    token: string;
    user: User;
}

