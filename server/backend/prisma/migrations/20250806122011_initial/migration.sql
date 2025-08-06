-- CreateTable
CREATE TABLE "user_account" (
    "username" TEXT NOT NULL PRIMARY KEY,
    "password" TEXT NOT NULL,
    "date_created" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "date_updated" DATETIME
);

-- CreateTable
CREATE TABLE "user_info" (
    "username" TEXT NOT NULL,
    "user_gender" TEXT NOT NULL DEFAULT 'Male',
    "user_balance" REAL NOT NULL DEFAULT 0,
    CONSTRAINT "user_info_username_fkey" FOREIGN KEY ("username") REFERENCES "user_account" ("username") ON DELETE RESTRICT ON UPDATE CASCADE
);

-- CreateTable
CREATE TABLE "user_coin_history" (
    "user_coin_history_id" TEXT NOT NULL PRIMARY KEY,
    "username" TEXT NOT NULL,
    "coin_inserted" INTEGER NOT NULL,
    "timestamp" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT "user_coin_history_username_fkey" FOREIGN KEY ("username") REFERENCES "user_account" ("username") ON DELETE RESTRICT ON UPDATE CASCADE
);

-- CreateTable
CREATE TABLE "user_pc_history" (
    "user_pc_history_id" TEXT NOT NULL PRIMARY KEY,
    "username" TEXT NOT NULL,
    "duration" INTEGER NOT NULL,
    "timestamp" DATETIME NOT NULL,
    "pc_number" TEXT NOT NULL,
    CONSTRAINT "user_pc_history_username_fkey" FOREIGN KEY ("username") REFERENCES "user_account" ("username") ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT "user_pc_history_pc_number_fkey" FOREIGN KEY ("pc_number") REFERENCES "pc_machine" ("pc_number") ON DELETE RESTRICT ON UPDATE CASCADE
);

-- CreateTable
CREATE TABLE "pc_machine" (
    "pc_number" TEXT NOT NULL PRIMARY KEY,
    "ip_address" TEXT NOT NULL,
    "mac_address" TEXT NOT NULL,
    "is_active" BOOLEAN NOT NULL DEFAULT false
);

-- CreateTable
CREATE TABLE "pc_session" (
    "session_id" TEXT NOT NULL PRIMARY KEY,
    "username" TEXT NOT NULL,
    "pc_number" TEXT NOT NULL,
    "start_time" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "end_time" DATETIME,
    "duration" INTEGER,
    CONSTRAINT "pc_session_username_fkey" FOREIGN KEY ("username") REFERENCES "user_account" ("username") ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT "pc_session_pc_number_fkey" FOREIGN KEY ("pc_number") REFERENCES "pc_machine" ("pc_number") ON DELETE RESTRICT ON UPDATE CASCADE
);

-- CreateTable
CREATE TABLE "admin_logs" (
    "log_id" TEXT NOT NULL PRIMARY KEY,
    "target_id" TEXT NOT NULL,
    "target" TEXT,
    "action" TEXT,
    "desc" TEXT NOT NULL,
    "timestamp" DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- CreateIndex
CREATE UNIQUE INDEX "user_info_username_key" ON "user_info"("username");

-- CreateIndex
CREATE INDEX "user_info_username_idx" ON "user_info"("username");

-- CreateIndex
CREATE INDEX "user_coin_history_username_idx" ON "user_coin_history"("username");

-- CreateIndex
CREATE INDEX "user_pc_history_username_timestamp_idx" ON "user_pc_history"("username", "timestamp");

-- CreateIndex
CREATE INDEX "user_pc_history_timestamp_idx" ON "user_pc_history"("timestamp");

-- CreateIndex
CREATE INDEX "pc_session_username_idx" ON "pc_session"("username");

-- CreateIndex
CREATE INDEX "pc_session_pc_number_idx" ON "pc_session"("pc_number");

-- CreateIndex
CREATE INDEX "admin_logs_target_id_idx" ON "admin_logs"("target_id");
