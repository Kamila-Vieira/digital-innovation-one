package one.digitalinnovation.classes.usuario;

public class ProgramaDoUsuario {
    public static void main(String[] args) {
        final var superUsuario = new SuperUsuario("root", "123hq@#3");
        superUsuario.getLogin();
        superUsuario.getSenha();
        String root = superUsuario.nome;
    }
}
