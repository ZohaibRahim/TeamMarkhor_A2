import javax.swing.*;
import java.io.*;
import java.util.*;

public class IOHandler {

    //Load customers from text file
    public static List<Customer> loadCustomersFromFile() {
        List<Customer> customers = new ArrayList<>();
        JFileChooser chooser = new JFileChooser();

        if (chooser.showOpenDialog(null) == JFileChooser.APPROVE_OPTION) {
            File file = chooser.getSelectedFile();

            try (Scanner sc = new Scanner(file)) {
                if (!sc.hasNextLine()) {
                    JOptionPane.showMessageDialog(null,
                            "Error: The file is empty.",
                            "Invalid Input", JOptionPane.ERROR_MESSAGE);
                    return customers;
                }

                int lineNum = 0;
                while (sc.hasNextLine()) {
                    lineNum++;
                    String line = sc.nextLine().trim();
                    if (line.isEmpty()) continue;

                    String[] parts = line.split("\\s+");
                    if (parts.length != 2) {
                        JOptionPane.showMessageDialog(null,
                                "Error: Invalid format on line " + lineNum +
                                ". Each line must have 2 integers (arrival, service).",
                                "Invalid Input", JOptionPane.ERROR_MESSAGE);
                        customers.clear();
                        return customers;
                    }

                    int arrival, service;
                    try {
                        arrival = Integer.parseInt(parts[0]);
                        service = Integer.parseInt(parts[1]);
                    } catch (NumberFormatException e) {
                        JOptionPane.showMessageDialog(null,
                                "Error: Non-numeric values on line " + lineNum + ".",
                                "Invalid Input", JOptionPane.ERROR_MESSAGE);
                        customers.clear();
                        return customers;
                    }

                    if (arrival < 0 || service <= 0) {
                        JOptionPane.showMessageDialog(null,
                                "Error: Arrival must be ≥ 0 and service > 0 (line " + lineNum + ").",
                                "Invalid Input", JOptionPane.ERROR_MESSAGE);
                        customers.clear();
                        return customers;
                    }

                    customers.add(new Customer(arrival, service));
                }

                JOptionPane.showMessageDialog(null,
                        "Successfully loaded " + customers.size() + " customers!",
                        "File Loaded", JOptionPane.INFORMATION_MESSAGE);

            } catch (IOException e) {
                JOptionPane.showMessageDialog(null,
                        "Error reading the file:\n" + e.getMessage(),
                        "File Error", JOptionPane.ERROR_MESSAGE);
            }
        }
        return customers;
    }

    // Export simulation results to text file
    public static void exportResultsToFile(String results) {
        if (results == null || results.trim().isEmpty()) {
            JOptionPane.showMessageDialog(null,
                    "No simulation results to export.",
                    "Export Error", JOptionPane.WARNING_MESSAGE);
            return;
        }

        JFileChooser chooser = new JFileChooser();
        if (chooser.showSaveDialog(null) == JFileChooser.APPROVE_OPTION) {
            File file = chooser.getSelectedFile();
            try (FileWriter writer = new FileWriter(file)) {
                writer.write(results);
                JOptionPane.showMessageDialog(null,
                        "Results exported successfully!",
                        "Export Complete", JOptionPane.INFORMATION_MESSAGE);
            } catch (IOException e) {
                JOptionPane.showMessageDialog(null,
                        "Error saving the file:\n" + e.getMessage(),
                        "File Error", JOptionPane.ERROR_MESSAGE);
            }
        }
    }
}
