<?php
if (!isset($_SESSION['nivel'])) {
    header("Location: login.php?msg=Você não tem autorização para acessar esse página.");
    exit();
}
