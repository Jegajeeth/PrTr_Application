export const PROGRESS_TTL = 5 * 60 * 1000; // 5 minutes

/**
 * Returns cached data for the given key, or null if missing/expired.
 * @param {string} key
 * @param {number|null} ttlMs - max age in ms; null means no expiry
 */
export function getCache(key, ttlMs = null) {
  try {
    const raw = sessionStorage.getItem(key);
    if (!raw) return null;
    const { data, timestamp } = JSON.parse(raw);
    if (ttlMs !== null && Date.now() - timestamp > ttlMs) {
      sessionStorage.removeItem(key);
      return null;
    }
    return data;
  } catch {
    return null;
  }
}

/**
 * Stores data in sessionStorage under the given key.
 * @param {string} key
 * @param {unknown} data
 */
export function setCache(key, data) {
  try {
    sessionStorage.setItem(
      key,
      JSON.stringify({ data, timestamp: Date.now() }),
    );
  } catch {
    // sessionStorage full or unavailable — fail silently
  }
}

/**
 * Removes the given key from sessionStorage.
 * @param {string} key
 */
export function invalidateCache(key) {
  sessionStorage.removeItem(key);
}
