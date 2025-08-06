-- RedefineTables
PRAGMA defer_foreign_keys=ON;
PRAGMA foreign_keys=OFF;
CREATE TABLE "new_admin_account" (
    "username" TEXT NOT NULL PRIMARY KEY,
    "password" TEXT NOT NULL,
    "date_created" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "date_updated" DATETIME
);
INSERT INTO "new_admin_account" ("date_created", "date_updated", "password", "username") SELECT "date_created", "date_updated", "password", "username" FROM "admin_account";
DROP TABLE "admin_account";
ALTER TABLE "new_admin_account" RENAME TO "admin_account";
PRAGMA foreign_keys=ON;
PRAGMA defer_foreign_keys=OFF;
