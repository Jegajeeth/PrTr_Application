import { defineConfig, loadEnv } from "vite";
import react from "@vitejs/plugin-react";

// https://vite.dev/config/
export default defineConfig(({mode}) => {

  const rootDir = import.meta.dirname || ".";
  const env = loadEnv(mode, rootDir, '');

  console.log("env: ", env);
  console.log("rootDir: ", rootDir);
  console.log(env.VITE_BACKEND_API_URL);
  console.log(env.VITE_FUNCTION_KEY);
  console.log(mode);

  return {
    plugins: [react()],
    server: {
      proxy: {
        "/api": {
          target: env.VITE_BACKEND_API_URL,
          changeOrigin: true,
          secure: false,
          configure: (proxy) => {
            proxy.on('proxyReq', (proxyReq) => {
              proxyReq.setHeader('x-functions-key', env.VITE_FUNCTION_KEY);
            })
          },
          header: {
            'x-functions-key': env.VITE_FUNCTION_KEY
          }
        },
      },
    },
  }
});
