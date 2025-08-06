import { PrismaClient } from "@prisma/client";
import { comparePassword, hashPassword } from "../utils/hash";

const prisma = new PrismaClient();

export const login = async (
  username: string,
  password: string,
  role: string
) => {
  let account;

  if (role == "User") {
    account = await prisma.user_account.findUnique({
      where: { username },
    });
  } else if (role == "Admin") {
    account = await prisma.admin_account.findUnique({
      where: { username },
    });
  }

  if (!account) return null;
  const isMatch = await comparePassword(password, account.password);
  if (!isMatch) return null;

  return account;
};

export const register = async (
  username: string,
  password: string,
  role: string
) => {
  let account;
  const hashedPassword = await hashPassword(password);

  if (role == "User") {
    account = await prisma.user_account.create({
      data: { username, password: hashedPassword },
    });
  } else if (role == "Admin") {
    account = await prisma.admin_account.create({
      data: { username, password: hashedPassword },
    });
  }

  if (!account) return null;
  return account.username;
};
