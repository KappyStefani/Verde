<style>
    .cabecalho {
        margin-left: 50px;
        margin-right: 50px;
        font-family: Arial, Helvetica, sans-serif;
        font-size: 1.1em;
        font-weight: bolder;
        background-color: #007bff;
        padding: 16px;
        border-radius: 10px;
        box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
        background-color: rgba(255, 255, 255, 0.9);
        color: red;
    }

    .cabecalho span {
        margin-right: 20px;
        color: #333;
        /* Cor do texto */
    }

    .cabecalho a {
        text-decoration: none;
        color: #007bff;
        /* Cor dos links azul */
        transition: color 0.3s;
        /* Transição de cor suave */
    }

    .cabecalho a:hover {
        color: #0056b3;
        /* Cor dos links azul mais escuro ao passar o mouse */
    }

    /* Estilo para o botão "Sair" */
    .cabecalho .logout-btn {
        background-color: #007bff;
        color: #fff;
        border: none;
        padding: 5px 10px;
        border-radius: 5px;
        cursor: pointer;
        transition: background-color 0.3s;
    }

    .cabecalho .logout-btn:hover {
        background-color: #0056b3;
    }

    /* Estilo para o separador */
    .cabecalho hr {
        border-color: #ddd;
        /* Cor do separador */
    }
</style>

<?php
session_start();
if (isset($_SESSION['nivel']) && $_SESSION['nivel'] == 10) {   //está logado e nivel 10
?>
    <div class="cabecalho" id="menu">
        <br>
        <span>Seja bem vindo <?= $_SESSION['nick'] ?></span>|
        <a href="logout.php">Sair </a> |
        <a href="listausuarios.php">Lista Usuários</a> |
        <a href="cadastrausuario.php">Novo Usuário</a> |
        <br>
        <hr>
    </div>

<?php
} else if (isset($_SESSION['nivel']) && $_SESSION['nivel'] == 1) {
?>
    <div class="cabecalho" id="menu">
        <br>
        <span>Seja bem vindo <?= $_SESSION['nick'] ?></span> |
        <a href="logout.php"> Sair </a> |
        <a href="listausuarios.php">Lista Usuários</a> |
        <br>
        <hr>
    </div>
<?php
} else {  // não logado
?>
    <div class="cabecalho" id="menu">
        <br>
        <span>Seja bem vindo. Faça seu <a href="login.php">login</a></span>
        <br>
        <hr>
    </div>
<?php
}
