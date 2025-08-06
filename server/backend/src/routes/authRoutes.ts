import { Router } from "express";
import { login, register } from "../controllers/authController";

const router = Router();

// Login
router.post("/login/user", login);
router.post("/login/admin", login);

// Register
router.post("/register/user", register);
router.post("/register/admin", register);

// Logout
// router.post("/logout/user", logout);
// router.post("/logout/admin", logout);

export default router;
