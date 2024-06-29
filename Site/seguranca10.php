<?php
if ($_SESSION['nivel'] != 10) {
    header("Location: login.php?msg=Você não tem autorização para acessar esse página.");
    exit();
}
