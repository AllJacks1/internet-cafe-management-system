import * as authService from "../services/authService";

export const login = async (req: any, res: any) => {
  const { username, password, role } = req.body;

  try {
    const account = await authService.login(username, password, role);

    if (!account)
      return res.status(401).json({ message: "Invalid credentials" });

    res.status(200).json({ message: `${role} logged in` });
  } catch (error) {
    res.status(500).json({ message: "Server error" });
  }
};

export const register = async (req: any, res: any) => {
  const { username, password, role } = req.body;

  try {
    const account = await authService.register(username, password, role);
    res.status(200).json({ account, message: `${role} account created` });
  } catch (error) {
    res.status(500).json({ message: "Server error" });
  }
};

// export const logout = async (req: any, res: any) => {
//   const { username, password, role } = req.body;

//   try {

//   } catch (error) {
//     res.status(500).json({ message: "Server error" });
//   }
// };
